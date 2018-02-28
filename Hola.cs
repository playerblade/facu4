using System;
using System.Collections.Generic;
namespace Bienvenida
{
    public class School{
        private string name;
        private List<Student> students;

        public School(string name){
            this.name=name;
            students=new List<Student>();
        }

        public string getName(){
            return name;
        }

        public void addStudent(Student newStudent){
            students.Add(newStudent);
        }

        public int showQuatityStudents(){
            return students.Count;
        }

        public string ShowNamesStudents(){
            string names="";
            foreach(Student s in students){
                names+="// " + s.getName();
            }
            return names;
        }


    }

    public class Student{
        private string name;

        public Student(string name){
            this.name=name;
        }
        public string getName(){
            return name;
        }

        public void hola(){
          Console.WriteLine("Caramba");
        }

    }


    public class Hola
    {
        static void Main(string[]agrs)
        {
            School fi=new School("Fac Ing");

            Student s1=new Student("Rodolfo T.");
            Student s2=new Student("Mariela Q.");
            Student s3=new Student("Jaime Y.");

            fi.addStudent(s1);
            fi.addStudent(s2);

            School teo=new School("Fac Teo");
            teo.addStudent(s3);

            Console.WriteLine(fi.getName());
            Console.WriteLine("La cantidad es: "+fi.showQuatityStudents());
            Console.WriteLine("Lista: "+fi.ShowNamesStudents());

            Console.WriteLine(teo.getName());
            Console.WriteLine("La cantidad es: "+teo.showQuatityStudents());
            Console.WriteLine("Lista: "+teo.ShowNamesStudents());

            //Console.WriteLine("La cantidad es: "+fi.showQuatityStudents());

            //fi.addStudent(s3);


            Console.WriteLine(fi.getName());
            Console.WriteLine("hOLA dsdssdmUMDO");
            Console.ReadKey();
        }
    }
}
