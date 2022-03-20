using System;
using System.Collections.Generic;
using System.Text;
using ULaw.ApplicationProcessor.Interfaces;

namespace Ulaw.ApplicationProcessor.Models
{
  public class ApplicationData : IApplicationData
  {
    private Guid _applicationId = new Guid();    

    public Guid GetApplicationId()
    {
      return _applicationId;
    }

    public string Faculty { get; set; }
    public string CourseCode { get; set; }
    public DateTime StartDate { get; set; }
    public string Title { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public bool RequiresVisa { get; set; }
  }
}
