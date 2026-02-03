#region Using directives
using System;
using UAManagedCore;
using OpcUa = UAManagedCore.OpcUa;
using FTOptix.UI;
using FTOptix.HMIProject;
using FTOptix.NativeUI;
using FTOptix.Retentivity;
using FTOptix.CoreBase;
using FTOptix.Core;
using FTOptix.NetLogic;
#endregion

public class RuntimeNetLogic1 : BaseNetLogic
{
    private PanelLoader panelLoader;

    public override void Start()
    {
        panelLoader = Owner as PanelLoader;
    }

    public override void Stop()
    {
        // Insert code to be executed when the user-defined logic is stopped
    }

    [ExportMethod]
    public void LoadPanel()
    {
        var screen2 = Project.Current.Get<ScreenType>("UI/Screens/Screen2");
        panelLoader.ChangePanel(screen2);
    }

}
