namespace Lab6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //using (var db = new DbEntities())
            //{
            //    #region [ ESPECIALITES ]
            //    Console.WriteLine("==== LISTADO INICIAL DE ESPECIALIDADES ====");
            //    db.Specialities.ToList().ForEach(x => Console.WriteLine("Especialidad: {0}", x.Speciality));
            //    Console.WriteLine("\n==== INGRESO DE NUEVA ESPECIALIDAD ====");
            //    var newSpeciality = db.Specialities.Create();
            //    newSpeciality.Speciality = "Urologia";
            //    db.Specialities.Add(newSpeciality);
            //    db.SaveChanges();
            //    Console.WriteLine("==== LISTADO ACTUAL DE ESPECIALIDADES ====");
            //    db.Specialities.ToList().ForEach(x => Console.WriteLine("Especialidad: {0}", x.Speciality));
            //    Console.WriteLine("\n==== ACTUALIZACION ESPECIALIDAD ====");
            //    var specialityToUpdate = db.Specialities.First();
            //    specialityToUpdate.Speciality = "Oncologia";
            //    db.SaveChanges();
            //    Console.WriteLine("==== LISTADO ACTUAL DE ESPECIALIDADES ====");
            //    db.Specialities.ToList().ForEach(x => Console.WriteLine("Especialidad: {0}", x.Speciality));
            //    Console.WriteLine("\n==== ELIMINACION DE LA ULTIMA ESPECIALIDAD ====");
            //    var idToDelete = db.Specialities.Max(x => x.Id);
            //    var toDelete = db.Specialities.Where(a => a.Id == idToDelete).First();
            //    db.Specialities.Remove(toDelete);
            //    db.SaveChanges();
            //    Console.WriteLine("==== LISTADO ACTUAL DE ESPECIALIDADES ====");
            //    db.Specialities.ToList().ForEach(x => Console.WriteLine("Especialidad: {0}", x.Speciality));
            //    #endregion

            //    #region [ MEDICS ]
            //    Console.WriteLine("==== LISTADO INICIAL DE MEDICOS ====");
            //    db.Medics.ToList().ForEach(x => Console.WriteLine("Nombre: {0}{1}, Matricula:{2}", x.FirstName, x.LastName, x.LicenseCode));
            //    Console.WriteLine("\n==== INGRESO DE NUEVO MEDICO ====");
            //    var newMedic = db.Medics.Create();
            //    newMedic.FirstName = "Jose";
            //    newMedic.LastName = "Perez";
            //    newMedic.LicenseCode = "98745";
            //    db.Medics.Add(newMedic);
            //    db.SaveChanges();
            //    Console.WriteLine("==== LISTADO ACTUAL DE MEDICOS ====");
            //    db.Medics.ToList().ForEach(x => Console.WriteLine("Nombre: {0}{1}, Matricula:{2}", x.FirstName, x.LastName, x.LicenseCode));
            //    Console.WriteLine("\n==== ACTUALIZACION MEDICO ====");
            //    var medicToUpdate = db.Medics.First();
            //    newMedic.LicenseCode = "55555";
            //    db.SaveChanges();
            //    Console.WriteLine("==== LISTADO ACTUAL DE MEDICOS ====");
            //    db.Medics.ToList().ForEach(x => Console.WriteLine("Nombre: {0}{1}, Matricula:{2}", x.FirstName, x.LastName, x.LicenseCode));
            //    Console.WriteLine("\n==== ELIMINACION DEL ULTIMO MEDICO ====");
            //    var idMedicToDelete = db.Medics.Max(x => x.Id);
            //    var medictToDelete = db.Medics.Where(a => a.Id == idMedicToDelete).First();
            //    db.Medics.Remove(medictToDelete);
            //    db.SaveChanges();
            //    Console.WriteLine("==== LISTADO ACTUAL DE MEDICOS ====");
            //    db.Medics.ToList().ForEach(x => Console.WriteLine("Nombre: {0}{1}, Matricula:{2}", x.FirstName, x.LastName, x.LicenseCode));
            //    #endregion

            //    #region [ PATIENTS ]
            //    Console.WriteLine("==== LISTADO INICIAL DE PACIENTES ====");
            //    db.Patients.ToList().ForEach(x => Console.WriteLine("Nombre: {0}{1}, Historico:{2}", x.Name, x.LastName, x.HistoryNumber));
            //    Console.WriteLine("\n==== INGRESO DE NUEVO PACIENTE ====");
            //    var newPatient = db.Patients.Create();
            //    newPatient.Name = "Pepito";
            //    newPatient.LastName = "Martinez";
            //    newPatient.HistoryNumber = 777;
            //    db.Patients.Add(newPatient);
            //    db.SaveChanges();
            //    Console.WriteLine("==== LISTADO ACTUAL DE PACIENTES ====");
            //    db.Patients.ToList().ForEach(x => Console.WriteLine("Nombre: {0}{1}, Historico:{2}", x.Name, x.LastName, x.HistoryNumber));
            //    Console.WriteLine("\n==== ACTUALIZACION ESPECIALIDAD ====");
            //    var patientToUpdate = db.Patients.First();
            //    patientToUpdate.HistoryNumber = 888;
            //    db.SaveChanges();
            //    Console.WriteLine("==== LISTADO ACTUAL DE PACIENTES ====");
            //    db.Patients.ToList().ForEach(x => Console.WriteLine("Nombre: {0}{1}, Historico:{2}", x.Name, x.LastName, x.HistoryNumber));
            //    Console.WriteLine("\n==== ELIMINACION DE LA ULTIMA ESPECIALIDAD ====");
            //    var idPatientToDelete = db.Patients.Max(x => x.Id);
            //    var patientToDelete = db.Patients.Where(a => a.Id == idPatientToDelete).First();
            //    db.Patients.Remove(patientToDelete);
            //    db.SaveChanges();
            //    Console.WriteLine("==== LISTADO ACTUAL DE PACIENTES ====");
            //    db.Patients.ToList().ForEach(x => Console.WriteLine("Nombre: {0}{1}, Historico:{2}", x.Name, x.LastName, x.HistoryNumber));
            //    #endregion
            //}
            Console.ReadLine();
        }
    }
}