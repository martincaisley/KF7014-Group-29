using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team29_Group_Project
{
    public interface IRepository<T>
    {
        void Add(T entity);
        T GetByID(int id);
        void Remove(T entity);
        IEnumerable<T> FindAll();
        void Save();
    }

    public class AppointmentRepository : IRepository<Appointment>
    {
        private MyDBEntities context = new MyDBEntities();
        public void Add(Appointment entity)
        {
            context.Appointments.Add(entity);
        }

        public IEnumerable<Appointment> FindAll()
        {
            return context.Appointments;
        }

        public Appointment GetByID(int id)
        {
            return context.Appointments.Find(id);
        }

        public void Remove(Appointment entity)
        {
            context.Appointments.Remove(entity);
        }
        public void Save()
        {
            context.SaveChanges();
        }
    }

    public class PatientRepository : IRepository<Patient>
    {
        private MyDBEntities context = new MyDBEntities();
        public void Add(Patient entity)
        {
            context.Patients.Add(entity);
        }

        public IEnumerable<Patient> FindAll()
        {
            return context.Patients;
        }

        public Patient GetByID(int patientID)
        {
            return context.Patients.Find(patientID);
        }

        public void Remove(Patient entity)
        {
            context.Patients.Remove(entity);
        }



        public void Save()
        {
            context.SaveChanges();
        }
    }
}
