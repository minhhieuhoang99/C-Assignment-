using System;

namespace pj1
{
    abstract class Person
    {
        private string firstName;
        private string lastName;
        private DateTime dateOfBirth;
        private string gender;
        private int phoneNumber;
        private string birthPlace;
        private int age;
        private bool isGraduated;

        public string firstName1 { get => firstName; set => firstName = value; }
        public string lastName1 { get => lastName; set => lastName = value; }
        public DateTime dateOfBirth1 { get => dateOfBirth; set => dateOfBirth = value; }
        public string gender1 { get => gender; set => gender = value; }
        public int phoneNumber1 { get => phoneNumber; set => phoneNumber = value; }
        public string birthPlace1 { get => birthPlace; set => birthPlace = value; }
        public int age1 { get => age; set => age = value; }
        public bool isGraduated1 { get => isGraduated; set => isGraduated = value; }
    }
}