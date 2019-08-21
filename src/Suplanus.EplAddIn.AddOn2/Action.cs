using Eplan.EplApi.ApplicationFramework;

namespace Suplanus.EplAddIn.AddOn2
{
  class Action : IEplAction
  {

    public void GetActionProperties(ref ActionProperties actionProperties) { }

    public bool OnRegister(ref string Name, ref int Ordinal)
    {
      Name = "AddOn2";
      Ordinal = 20;

      return true;
    }

    public bool Execute(ActionCallingContext oActionCallingContext)
    {
      Test.Library.Test.Normal();

      return true;
    }


  }
}
