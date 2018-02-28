using System;
using System.Collections.Generic;

namespace Institution
{
  public class Person
  {
    protected string name;
    protected int age;
    protected int cI;

    public void chargeData(string name, int age, int cI){
      this.name=name;
      this.age=age;
      this.cI=cI;
    }

    public string getName(){
      return name;
    }

    public int getAge(){
      return age;
    }

    public int getCI(){
      return cI;
    }
  }

}
