using System;
using System.Collections.Generic;
using System.Text;
using ULaw.ApplicationProcessor.Enums;

namespace ULaw.ApplicationProcessor.Interfaces
{
  public interface IApplication
  {
    string Process();
    DegreeGradeEnum DegreeGrade { get; set; }
    DegreeSubjectEnum DegreeSubject { get; set; }
  }
}
