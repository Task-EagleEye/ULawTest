using System;
using System.Collections.Generic;
using System.Text;

namespace ULaw.ApplicationProcessor.Interfaces
{
  public interface IApplicationData
  {
    Guid GetApplicationId();
    string Faculty { get; set; }
    string CourseCode { get; set; }
    DateTime StartDate { get; set; }
    string Title { get; set; }
    string FirstName { get; set; }
    string LastName { get; set; }
    DateTime DateOfBirth { get; set; }
    bool RequiresVisa { get; set; }
  }
}
