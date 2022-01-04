using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace Dependency.Models
{
    //Manuel IOC Container 
    public class Creator
    {
        private Creator()
        {
        }
        public static Notification CreateBildirimInstance()
        {
            return new Notification(new SmsBildirim());
        }

    }
    public class Notification
    {
        private IBildirim _bildirim;
        public Notification(IBildirim bildirim)
        {
            _bildirim = bildirim;
        }
        public void Yap()
        {

            _bildirim.Gonder();

            Debug.WriteLine("Bildirim yapıldı.");
        }
    }
    public interface IBildirim
    {
        void Gonder();
    }
    public class EPostaBildirim : IBildirim
    {
        public void Gonder()
        {
            Debug.WriteLine("E-posta gönderildi.");
        }

    }
    public class SmsBildirim : IBildirim
    {
        public void Gonder()
        {
            Debug.WriteLine("Sms gönderildi.");
        }
    }
}