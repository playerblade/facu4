using System;
using System.Collections.Generic;

namespace Institution
{
  public class School
  {
    private string name;
    private List<Teacher> teacher;
    private Student student;

      public School(string name){
        this.name=name;
        teacher= new List<Teacher>();
      }

      public void chargeStudent(Student student){
        this.student=student;
      }

      /*public Teacher showTeacher(int index){
        return (teacher == null?null:teacher[index]);
      }*/

      public string showSubject(){
        string name="";
        foreach(Teacher tea in teacher){
          name += "// " + tea.getNameSubject();
        }
        return name;
      }

      public int showQuantityProgra(){
        int count=0;
        string aux="Programacion";
        foreach(Teacher tea in teacher){
          name = tea.getNameSubject();
          if(name == aux){
            count++;
          }
        }
        return count;
      }

      public void addTeacher(Teacher newteacher){
        teacher.Add(newteacher);
      }

    static void Main(string[]agrs)
    {
      //int i, MAX =0;
      Student student = new Student();
      student.chargeData("Pedro", 18, 134344);
      School school = new School("Facu Ingenieria");
      school.chargeStudent(student);
      Subject subject;
      Teacher teacher1 = new Teacher();
      Teacher teacher2 = new Teacher();
      Teacher teacher3 = new Teacher();

      teacher1.chargeData("Francisco", 30, 1223243);
      subject = new Subject("Idiomas");
      teacher1.addSubject(subject);
      school.addTeacher(teacher1);

      teacher2.chargeData("Brandon", 40, 1208302);
      subject = new Subject("Programacion");
      teacher2.addSubject(subject);
      school.addTeacher(teacher2);

      teacher3.chargeData("Poos", 30, 23328);
      subject = new Subject("Programacion");
      teacher3.addSubject(subject);
      school.addTeacher(teacher3);

      

      Console.WriteLine("Cuantas Materias Programacion hay?");
      Console.WriteLine("cantidad progra: " + school.showQuantityProgra());
      Console.WriteLine("--> " + school.showSubject());

    }
  }

}
