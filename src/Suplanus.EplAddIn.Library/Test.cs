using System.Windows;
using Eplan.EplApi.DataModel;

namespace Suplanus.Test.Library
{
  public class Test
  {
    // ReSharper disable once NotAccessedField.Local
    private int _projectsCount;

    public Test()
    {
      _projectsCount = new ProjectManager().OpenProjects.Length; // Do this to ensure EPLAN API called
    }

    public static void Costura()
    {
      MessageBox.Show("Costura");
    }

    public static void Normal()
    {
      MessageBox.Show("1");
    }
  }
}
