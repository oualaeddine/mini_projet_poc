using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using AppBiblio.views.members;
using AppBiblio.views.ouvrages;
using HumansCRUD;
using HumansLib;
using HumansLib.profs;

namespace AppBiblio.api
{
    public class membersApi
    {
        private static readonly string MEMBERS_API_ADD_MEMBER_URL = "http://localhost/ServiceMembersCRUD.svc/add";
        public string ip { get; private set; }
        public int port { get; private set; }


        public membersApi()
        {
            try
            {
                TcpChannel chl = new TcpChannel();
                ChannelServices.RegisterChannel(chl, false);
                Console.WriteLine("Client: Canal enregistré");

                profCrud = (IProfCRUD) Activator.GetObject(
                    typeof(IProfCRUD),
                    "tcp://" + ip + ":" + port + "/profsCRUD");
                studentCRUD = (IStudentCRUD) Activator.GetObject(
                    typeof(IStudentCRUD),
                    "tcp://" + ip + ":" + port + "/studentsCRUD");
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERREUR :" + ex.Message);
            }
        }

        public IStudentCRUD studentCRUD { get; set; }

        public IProfCRUD profCrud { get; set; }


        public void addMember(Student stu)
        {
            studentCRUD.insert(stu);
        }

        public void addMember(Prof prof)
        {
            profCrud.insert(prof);
        }


        internal void delete(int value, string type, members_list.OnMemberDeleted onMemberDeleted)
        {
            if (type.Equals("Etudiant"))
            {
                onMemberDeleted(studentCRUD.delete(new Student {id = value}));
            }
            else
            {
                onMemberDeleted(profCrud.delete(new Prof() {id = value}));
            }
        }

        public void getAll(members_list.OnGetData result)
        {
            LinkedList<Student> students = studentCRUD.getAll();
            LinkedList<Prof> profs = profCrud.getAll();

            LinkedList<Human> membres = new LinkedList<Human>();

            foreach (var student in students)
            {
                membres.AddLast(student);
            }

            foreach (var prof in profs)
            {
                membres.AddLast(prof);
            }

            result(membres);
        }

        public void trouverMembre(string search, ReserverPreter.OnMemberFound found)
        {
            Student student = studentCRUD.findOne(search);
            Prof prof = profCrud.findOne(search);
            Human member = null;
            bool isSuspended = false;
            if (student != null)
            {
                member = student;
                isSuspended = studentCRUD.isSuspended(student);
            }

            if (prof != null)
            {
                member = prof;
                isSuspended = profCrud.isSuspended(prof);
            }

            found(member, isSuspended);
        }
    }
}