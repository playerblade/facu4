using System;
using System.Collections.Generic;

namespace Institution
{
    public class Teacher:Person
    {
      private Subject subject;


      public void addSubject(Subject subject){
        this.subject=subject;
      }

      public string getNameSubject(){
        return  subject.getName();
      }

    }
}
