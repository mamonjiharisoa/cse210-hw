using System;

public class Job {

  public string _jobTitle ;
  public string _Company ;
  public int  _startYear ;
  public int _endYear ;

 public void Display(){

    Console.WriteLine($"{_jobTitle},{_Company} {_startYear} {_endYear}");
 }
}

