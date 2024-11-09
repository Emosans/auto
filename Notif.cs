using System;
using System.Windows.Forms; 

class Notif{
    public void ShowNotification(string notif){
        var notificon = new NotifyIcon{
            Visible=true,
            Icon = SystemIcons.Information,
            BalloonTipTitle = "Notification",
            BalloonTipText = notif,
        };

        notificon.ShowBalloonTip(0000);
    }
}