using System;
using System.Collections.Generic;

namespace DesignPatterns.Creational.Builder.CSharp.Examples.Static
{
    public static class StaticEmailBuilder
    {
        public static void AppendToRecipient(this StandardEmail standardEmail, string to)
        {
            if (standardEmail.To == null)
            {
                standardEmail.To = new List<string>();
            }

            if (to != null)
            {
                standardEmail.To.Add(to);
                return;
            }

            throw new ArgumentNullException("Email must contain a valid recipient");
        }

        public static void AddFrom(this StandardEmail standardEmail)
        {
            standardEmail.From = "email@email.email";
        }

        public static void AddTitle(this StandardEmail standardEmail, string title)
        {
            if (title != null && title.Length > 5)
            {
                standardEmail.Title = title;
                return;
            }

            throw new ArgumentNullException("Title must contain an initialised title with atleast 5 letters");
        }

        public static void AddBody(this StandardEmail standardEmail, string body)
        {
            standardEmail.Body = body ?? "";
        }
    }
}
