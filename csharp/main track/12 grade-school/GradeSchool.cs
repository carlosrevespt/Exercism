using System;
using System.Linq;
using System.Collections.Generic;

public class GradeSchool
{
    private MyRoster tempRoster;
    public GradeSchool () {
        tempRoster = new MyRoster();
    }
    
    public void Add(string student, int grade)
    {
        tempRoster.addStudent(student, grade);
    }

    public IEnumerable<string> Roster() => tempRoster.getFullRoster();

    public IEnumerable<string> Grade(int grade) => tempRoster.getGradeRoster(grade);
}

class MyRoster {
    private SortedList<int, List<string>> roster = new SortedList<int, List<string>>();

    public void addStudent (string name, int grade) {
        if(roster.ContainsKey(grade)){
            roster[grade].Add(name);
        } else {
            roster.Add(grade, new List<string> { name });
        }
        
    }

    public IEnumerable<string> getGradeRoster(int grade) => roster.ContainsKey(grade) ? roster[grade].OrderBy(i => i).ToList() : new List<string>();

    public IEnumerable<string> getFullRoster(){
        List<string> temp = new List<string>();
        foreach (List<string> grd in roster.Values) temp.AddRange(grd.OrderBy(i => i));

        return temp;
    }


}