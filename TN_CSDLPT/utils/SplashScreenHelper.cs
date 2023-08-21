using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TN_CSDLPT.utils
{
    internal class SplashScreenHelper
    {
        public static void OpenSlashScreenWhenStart(DevExpress.XtraEditors.XtraForm form)
        {
            SplashScreenManager.ShowFluentSplashScreen(
                title: "TN_CSDLPT",
                subtitle: "Ditributed Dabatase Demo Application",
                leftFooter: "Copyright © 2023 - 2023 by Phat Luu" + Environment.NewLine + "All Rights reserved.",
                rightFooter: "Starting...",
                loadingIndicatorType: FluentLoadingIndicatorType.Dots,
                useFadeIn: true,
                useFadeOut: false,
                opacity: 90,
                parentForm: form
                );

            System.Threading.Thread.Sleep(8000);

            SplashScreenManager.CloseForm();
        }
    }
}
