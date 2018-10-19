﻿using Eplan.EplApi.ApplicationFramework;

namespace Suplanus.EplAddIn.Costura
{
  public class AddIn: IEplAddIn
  {
    public bool OnRegister(ref bool isLoadingOnStart)
    {
      isLoadingOnStart = true;
      return true;
    }

    public bool OnUnregister()
    {
      return true;
    }

    public bool OnInit()
    {
      return true;
    }

    public bool OnInitGui()
    {
      return true;
    }

    public bool OnExit()
    {
      return true;
    }

  }
}
