using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace tootAConsole
{
    public class getData
    {

        /// WCF service
        private tootAService.Service1Client service = new tootAService.Service1Client();

        public void InitSettings()
        {

        }

        public void GetAndReportStatus()
        {
            // we ask the WCF service (UNET_service) what exercises there are and display them on the screen by making buttons
            // visible/invisible and also set the statusled
            if (service.State != System.ServiceModel.CommunicationState.Opened)
            {
                service.Open();
            }
            //we moeten  de huidige status ophalen van de instructeur/exercises/trainee/roles/radios
            //en hiermee de knoppen de juiste kleur geven

            try
            {
                Console.Clear();
                Console.Write("************************************************************************************");
                Console.Write(Environment.NewLine);

                Console.Write(string.Format("tootA 2018 - Messages build date: {0}", utils.GetLinkerDateTime(Assembly.GetExecutingAssembly(), null)));
                Console.Write(Environment.NewLine);
                Console.Write("tootA Status weergever ");
                Console.Write(Environment.NewLine);
                Console.Write("************************************************************************************");
                Console.Write(Environment.NewLine);
                Console.Write(Environment.NewLine);


                //Instructors
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("------------------------------------------------------------------------------------");
                Console.Write(Environment.NewLine);
                Console.Write(DateTime.Now.ToString() + " Messages ontvangen en aanmeldstatus");
                Console.Write(Environment.NewLine);
                Console.Write("------------------------------------------------------------------------------------");
                Console.Write(Environment.NewLine);
                //  Instructor currentInstructor = service.GetAllInstructorData(InstructorID);
                Console.Write(Environment.NewLine);
                var msglist = service.getMessages();

                List<tootAService.tootAMessage> messagelist = msglist.ToList<tootAService.tootAMessage>();
                if (messagelist.Count == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("No new Messages");
                    Console.Write(Environment.NewLine);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {

                    foreach (tootAService.tootAMessage msg in messagelist.OrderByDescending(x => x.EntryDateTime)) //then ENABLE them, based on whatever comes from the service
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Msg:: " + msg.EntryDateTime + " > " + msg.Message);


                        Console.Write(Environment.NewLine);
                    }
                    //foreach (UNET_Classes.Trainee insttrain in instr.TraineesAssigned)
                    //{
                    //    Console.ForegroundColor = ConsoleColor.Blue;
                    //    Console.Write("   Assigned   Trainee ID: " + insttrain.ID + " Trainee descr: " + insttrain.Name);
                    //    Console.Write(Environment.NewLine);

                    //}

                    //Console.Write(Environment.NewLine);

                    //foreach (UNET_Classes.Exercise exe in instr.Exercises)
                    //{
                    //    Console.ForegroundColor = ConsoleColor.Yellow;
                    //    Console.Write("             Exerciseid: " + exe.Number + " ExerciseName: " + exe.ExerciseName + "  Specificationname: " + exe.SpecificationName + " > ");

                    //    if (exe.Selected == true)
                    //    {
                    //        Console.ForegroundColor = ConsoleColor.Green;
                    //        Console.Write("SELECTED");
                    //    }
                    //    else
                    //    {
                    //        Console.ForegroundColor = ConsoleColor.Red;
                    //        Console.Write("NOT SELECTED");
                    //    }

                    //    Console.Write(Environment.NewLine);
                    //    foreach (UNET_Classes.Trainee trn in exe.TraineesAssigned)
                    //    {
                    //        Console.ForegroundColor = ConsoleColor.Yellow;
                    //        Console.Write("                 Assigned Trainee:  Traineeid:: " + trn.ID + "  Trainee name: " + trn.Name);
                    //        Console.Write(Environment.NewLine);

                    //        foreach (UNET_Classes.Role rol in trn.Roles)
                    //        {
                    //            Console.ForegroundColor = ConsoleColor.White;
                    //            Console.Write("                      Assigned trainee-role: " + rol.ID + "  Role name: " + rol.Name);
                    //            Console.Write(Environment.NewLine);
                    //        }
                    //    }

                    //    foreach (UNET_Classes.Role rol in exe.RolesAssigned)
                    //    {
                    //        Console.ForegroundColor = ConsoleColor.Yellow;
                    //        Console.Write("                Assigned exercise role: " + rol.ID + "  Role name: " + rol.Name);
                    //        Console.Write(Environment.NewLine);
                    //    }

                    //    foreach (UNET_Classes.Radio rad in exe.RadiosAssigned)
                    //    {
                    //        Console.ForegroundColor = ConsoleColor.Cyan;
                    //        Console.Write("                Assigned radio: " + rad.ID + "  Radio name: " + rad.Description + " NoiseLevel: " + rad.NoiseLevel + " Freq: " + rad.Frequency);
                    //        Console.Write(Environment.NewLine);
                    //    }

                    //    foreach (UNET_Classes.Platform plat in exe.PlatformsAssigned)
                    //    {
                    //        Console.ForegroundColor = ConsoleColor.DarkYellow;
                    //        Console.Write("                Assigned platform: " + plat.ID + "  Platform name: " + plat.Description + " Short: " + plat.ShortDescription);
                    //        Console.Write(Environment.NewLine);

                    //    }

                    //}                    
                    //          }
                    //      }


                    //exercises
                    //        var resultlist = service.GetExercises();
                    //        List<UNET_Classes.Exercise> lst = resultlist.ToList<UNET_Classes.Exercise>(); //C# v3 manier om een array in een list te krijgen
                    //        if (lst.Count == 0)
                    //        {
                    //            Console.ForegroundColor = ConsoleColor.Red;
                    //            Console.Write("No data in UNET_Service");
                    //            Console.Write(Environment.NewLine);
                    //            Console.ForegroundColor = ConsoleColor.White;
                    //        }
                    //        else
                    //        {
                    //            Console.ForegroundColor = ConsoleColor.Green;
                    //            Console.Write(DateTime.Now.ToString() + " Exercises");

                    //            foreach (UNET_Classes.Exercise exercise in lst) //then ENABLE them, based on whatever comes from the service
                    //            {
                    //                Console.ForegroundColor = ConsoleColor.White;
                    //                Console.Write("Exercise::  " + exercise.Number + " Name: " + exercise.ExerciseName);
                    //                Console.Write(Environment.NewLine);


                    //                foreach (UNET_Classes.Trainee trn in exercise.TraineesAssigned)
                    //                {
                    //                    Console.ForegroundColor = ConsoleColor.Magenta;
                    //                    Console.Write(string.Format("Exercise: {2} Trainee: {0} Name: {1}", trn.ID, trn.Name, exercise.Number));
                    //                    Console.Write(Environment.NewLine);

                    //                }

                    //            }
                    //            //trainee
                    //            Console.ForegroundColor = ConsoleColor.Green;
                    //            Console.Write(DateTime.Now.ToString() + " Trainees");

                    //            var trlst = service.GetTrainees();
                    //            List<UNET_Classes.Trainee> lsttr = trlst.ToList<UNET_Classes.Trainee>(); //C# v3 manier om een array in een list te krijgen

                    //            foreach (UNET_Classes.Trainee trn in lsttr)
                    //            {
                    //                Console.Write(string.Format("Trainee: {0}  Name: {1}", trn.ID, trn.Name));
                    //                Console.Write(Environment.NewLine);

                    //            }


                    //            //radio
                    //            Console.ForegroundColor = ConsoleColor.Green;
                    //            Console.Write(DateTime.Now.ToString() + " Radio");

                    //            var radlst = service.GetRadios();
                    //            List<UNET_Classes.Radio> lstrad = radlst.ToList<UNET_Classes.Radio>(); //C# v3 manier om een array in een list te krijgen

                    //            foreach (UNET_Classes.Radio rad in lstrad)
                    //            {
                    //                Console.Write(string.Format("Radio: {0}  Name: {1}  Freq: {2} SE: {3}", rad.ID, rad.Description, rad.Frequency, rad.SpecialEffect));
                    //                Console.Write(Environment.NewLine);

                    //            }

                    //            //platform
                    //            Console.ForegroundColor = ConsoleColor.Green;
                    //            Console.Write(DateTime.Now.ToString() + " Platforms");

                    //            var platlst = service.GetPlatforms();
                    //            List<UNET_Classes.Platform> lstPlat = platlst.ToList<UNET_Classes.Platform>(); //C# v3 manier om een array in een list te krijgen

                    //            foreach (UNET_Classes.Platform platform in lstPlat)
                    //            {
                    //                Console.Write(string.Format("Platform: {0}  ShortDescription: {1}", platform.ID, platform.ShortDescription));
                    //                Console.Write(Environment.NewLine);
                    //            }

                    //            //role
                    //            Console.ForegroundColor = ConsoleColor.Green;
                    //            Console.Write(DateTime.Now.ToString() + " Roles");

                    //            var rllst = service.GetRoles();
                    //            List<UNET_Classes.Role> extrole = rllst.ToList<UNET_Classes.Role>(); //C# v3 manier om een array in een list te krijgen

                    //            foreach (UNET_Classes.Role ex in extrole)
                    //            {
                    //                Console.Write(string.Format("Role: {0}  Name: {1}", ex.ID, ex.Name));
                    //                Console.Write(Environment.NewLine);
                    //                foreach (UNET_Classes.Platform plat in ex.PlatformsAssigned)
                    //                {
                    //                    Console.Write(string.Format("         Met Platform:  {0}  Shortdescription: {1}", plat.ID, plat.ShortDescription));
                    //                    Console.Write(Environment.NewLine);

                    //                }

                    //            }

                    //        }
                    //        //trainees
                    //        Console.ForegroundColor = ConsoleColor.White;
                    //        Console.Write("------------------------------------------------------------------------------------");
                    //        Console.Write(Environment.NewLine);
                    //        Console.Write(DateTime.Now.ToString() + " Trainees ontvangen van SIM en aanmeldstatus");
                    //        Console.Write(Environment.NewLine);
                    //        Console.Write("------------------------------------------------------------------------------------");
                    //        Console.Write(Environment.NewLine);


                    //        var resultlisttrainees = service.GetTrainees();
                    //        List<UNET_Classes.Trainee> lstTrainee = resultlisttrainees.ToList<UNET_Classes.Trainee>(); //C# v3 manier om een array in een list te krijgen
                    //        if (lstTrainee.Count == 0)
                    //        {
                    //            Console.ForegroundColor = ConsoleColor.Red;
                    //            Console.Write("No data in UNET_Service for trainees");
                    //            Console.Write(Environment.NewLine);
                    //            Console.ForegroundColor = ConsoleColor.White;
                    //        }
                    //        else
                    //        {
                    //            foreach (UNET_Classes.Trainee trainee in lstTrainee) //then ENABLE them, based on whatever comes from the service
                    //            {
                    //                Console.ForegroundColor = ConsoleColor.White;
                    //                Console.Write("Trainee::  " + trainee.ID + " Name: " + trainee.Name + "  Aangemeld sinds: " + trainee.RegisteredSince.ToString() + " Online: ");
                    //                if (trainee.Online == true)
                    //                {
                    //                    Console.ForegroundColor = ConsoleColor.Green;
                    //                    Console.Write("ONLINE");
                    //                }
                    //                else
                    //                {
                    //                    Console.ForegroundColor = ConsoleColor.Red;
                    //                    Console.Write("OFFLINE");
                    //                }



                    //                Console.Write(Environment.NewLine);
                    //                foreach (Radio rn in trainee.Radios)
                    //                {
                    //                    Console.ForegroundColor = ConsoleColor.Cyan;
                    //                    Console.Write(string.Format("                              Assigned radio: {0} Trainee: {0} Descr: {1} Noise: {2}", rn.ID, rn.Description, rn.NoiseLevel));
                    //                    Console.Write(Environment.NewLine);

                    //                }

                    //            }
                    //        }
                    //        //Assists
                    //        Console.ForegroundColor = ConsoleColor.Cyan;
                    //        Console.Write("------------------------------------------------------------------------------------");
                    //        Console.Write(Environment.NewLine);
                    //        Console.Write(DateTime.Now.ToString() + " Assists");
                    //        Console.Write(Environment.NewLine);
                    //        Console.Write("------------------------------------------------------------------------------------");
                    //        Console.Write(Environment.NewLine);


                    //        var resultlistassists = service.GetAssists(string.Empty);
                    //        List<UNET_Classes.Assist> lstAssist = resultlistassists.ToList<UNET_Classes.Assist>();
                    //        if (lst.Count == 0)
                    //        {
                    //            Console.ForegroundColor = ConsoleColor.Red;
                    //            Console.Write("No data in UNET_Service for Assist");
                    //            Console.Write(Environment.NewLine);
                    //            Console.ForegroundColor = ConsoleColor.White;
                    //        }
                    //        else
                    //        {
                    //            foreach (UNET_Classes.Assist assist in lstAssist) //then ENABLE them, based on whatever comes from the service
                    //            {
                    //                Console.ForegroundColor = ConsoleColor.Cyan;
                    //                Console.Write("Pending assist::  " + assist.ID + " Started by: " + assist.TraineeID + " " + assist.TraineeInfo + "  Requested: " + assist.RequestTime.ToString());
                    //                Console.Write(Environment.NewLine);


                    //            }
                    //        }


                    //        //PTT
                    //        Console.ForegroundColor = ConsoleColor.Cyan;
                    //        Console.Write("------------------------------------------------------------------------------------");
                    //        Console.Write(Environment.NewLine);
                    //        Console.Write(DateTime.Now.ToString() + " PTT QUEUE");
                    //        Console.Write(Environment.NewLine);
                    //        Console.Write("------------------------------------------------------------------------------------");
                    //        Console.Write(Environment.NewLine);

                    //        var resultlistptt = service.GetPTTQueue();
                    //        List<PTTcaller> lstPtt = resultlistptt.ToList<PTTcaller>();
                    //        if (lst.Count == 0)
                    //        {
                    //            Console.ForegroundColor = ConsoleColor.Red;
                    //            Console.Write("No data in UNET_Service for the PTTQueue");
                    //            Console.Write(Environment.NewLine);
                    //            Console.ForegroundColor = ConsoleColor.White;
                    //        }
                    //        else
                    //        {
                    //            foreach (PTTcaller pt in lstPtt)
                    //            {
                    //                Console.ForegroundColor = ConsoleColor.Gray;
                    //                Console.Write("PTT QUEUE::  " + pt.ID + " Started by: " + pt.PTTCallerID + " " + pt.User + "  Requested: " + pt.PTTDateTime.ToString() + " Acknowledged: ");
                    //                if (pt.Acknowledged == true)
                    //                {
                    //                    Console.ForegroundColor = ConsoleColor.Gray;
                    //                    Console.Write("Acknowledged");
                    //                }
                    //                else
                    //                {
                    //                    Console.ForegroundColor = ConsoleColor.Red;
                    //                    Console.Write("Active");
                    //                }
                    //                Console.Write(Environment.NewLine);


                    //            }
                    //        }
                    //        Console.ForegroundColor = ConsoleColor.Green;
                    //        Console.Write("************************************************************************************");
                    //        Console.Write(Environment.NewLine);
                    //        Console.Write(DateTime.Now.ToString() + " The above is the status at time: " + DateTime.Now.ToString());
                    //        Console.Write(Environment.NewLine);
                    //        Console.Write("************************************************************************************");
                    //        Console.Write(Environment.NewLine);

                    //    }
                    //   

                }
            }

            catch (Exception ex)
            {
                string message = ex.Message;
                throw ex;
            }
        }
    }
}

