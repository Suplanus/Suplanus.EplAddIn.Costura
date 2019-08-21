using System.Windows;
using Eplan.EplApi.DataModel;

namespace Suplanus.Test.Library
{
  public class MergeTest
  {
    // ReSharper disable once NotAccessedField.Local
    private int _projectsCount;

    public MergeTest()
    {
      _projectsCount = new ProjectManager().OpenProjects.Length; // Do this to ensure EPLAN API called
    }

    public static void Costura()
    {
      MessageBox.Show("Costura");
    }

    public static void Normal()
    {
      MessageBox.Show("2");
    }
  }
}
