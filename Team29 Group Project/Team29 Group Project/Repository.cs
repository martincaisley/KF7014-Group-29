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
        IEnumerable<T> GetAll();
        void Remove(T entity);
        void Save();
    }
    public class Repository<T> : IRepository<T> where T : class
    {
        private MyDBEntities context;

        public Repository(MyDBEntities context)
        {
            this.context = context;
        }

        public void Add(T entity)
        {
            context.Set<T>().Add(entity);
        }

        public IEnumerable<T> GetAll()
        {
            return context.Set<T>().ToList();
        }

        public T GetByID(int id)
        {
            return context.Set<T>().Find(id);
        }

        public void Remove(T entity)
        {
            context.Set<T>().Remove(entity);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
    /*public class AppointmentRepository : IRepository<Appointment>
    {
        private MyDBEntities context = new MyDBEntities();
        public void Add(Appointment entity)
        {
            context.Appointments.Add(entity);
        }
        public IEnumerable<Appointment> GetAll()
        {
            return context.Appointments.ToList();
        }

        public Appointment GetByID(int id)
        {
            return context.Appointments.Find(id);
        }

        public void Remove(Appointment entity)
        {
            context.Appointments.Remove(entity);
        }
    }

    public class PatientRepository : IRepository<Patient>
    {
        private MyDBEntities context = new MyDBEntities();
        public void Add(Patient entity)
        {
            context.Patients.Add(entity);
        }
        public IEnumerable<Patient> GetAll()
        {
            return context.Patients.ToList();
        }

        public Patient GetByID(int patientID)
        {
            return context.Patients.Find(patientID);
        }

        public void Remove(Patient entity)
        {
            context.Patients.Remove(entity);
        }
    }*/

}
