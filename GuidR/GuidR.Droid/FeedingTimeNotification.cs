using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System.Threading;

namespace GuidR.Droid {
    [Service]
    public class FeedingTimeNotification : Service {

        public int lookAheadTime = 5;
        public override StartCommandResult OnStartCommand(Intent intent, StartCommandFlags flags, int startId) {

            
            int TimerWait = 60000;
            Timer _timer;
            int notificationCount = 0;
            List<FeedingTime> usedFeedingtimes = new List<FeedingTime>();


            Thread t = new Thread(() => {


                _timer = new Timer(o => 
                {
                    FeedingTime timeToCheck;
                    DateTime now = DateTime.Now;
                    foreach(Animal a in AttractionDataBase.animalsToWatch) {
                            if(a.HasFeedingTime && a.IsInSeason) {
                                timeToCheck = a.NextFeeding;
                                Console.WriteLine(a.Name + " - " + a.NextFeeding + " : " + timeToCheck.TimeOfDay.AddMinutes(-5));

                                if (now.Hour == timeToCheck.TimeOfDay.AddMinutes(-5).Hour && 
                                   now.Minute == timeToCheck.TimeOfDay.AddMinutes(-5).Minute) {


                                    Notification.Builder builder = new Notification.Builder(this)
                                    .SetContentTitle("Fodring hos " + a.Name)
                                    .SetContentText("om " + lookAheadTime + " minutter.")
                                    .SetSmallIcon((int)a.Image);
                                    builder.SetDefaults(NotificationDefaults.Sound | NotificationDefaults.Vibrate);

                                    Notification notification = builder.Build();

                                    NotificationManager notificationManager =
                                        GetSystemService(Context.NotificationService) as NotificationManager;

                                    notificationManager.Notify(notificationCount++, notification);
                                }
                            }
                        }
                    Console.WriteLine(DateTime.Now.Minute);

                },
                      null,
                      0,
                      TimerWait);
            });

            if(t.IsAlive == false)
            t.Start();

            return StartCommandResult.NotSticky;

        }

        void something() {
                   }



            
    public override IBinder OnBind(Intent intent) {
            throw new NotImplementedException();
        }
    }
}