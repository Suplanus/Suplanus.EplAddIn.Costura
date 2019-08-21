using Eplan.EplApi.ApplicationFramework;
using Suplanus.Test.Library;

namespace Suplanus.EplAddIn.Costura
{
  class Action : IEplAction
  {

    public void GetActionProperties(ref ActionProperties actionProperties) { }

    public bool OnRegister(ref string Name, ref int Ordinal)
    {
      Name = "Costura";
      Ordinal = 20;

      return true;
    }

    public bool Execute(ActionCallingContext oActionCallingContext)
    {
      Test.Library.Test.Costura();

      return true;
    }


  }
}
