using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace verisoft
{
    public enum Lmood
    {
        MOOD_HAPPY=0,
        MOOD_SCARED=1
    }
    public abstract class Animal
    {
        protected bool mammals;//יונקים
        protected bool comivorous;//טורפים
        protected int mood ;//מצב רוח

        public Animal(bool mammals, bool comivorous,int mood)
        {
           this.mammals = mammals;
           this.comivorous = comivorous;
           this.mood = mood;
        }
        public Lmood CurrentMood // נכס שמחזיר את מצב הרוח כ-enum
        {
            get { return (Lmood)mood; }            // המרה לעבודה עם ה-enum
            set { mood = (int)value; }
        }

        public abstract void WhatMood();// או להפך מה החיה עושה כשהיא במצב רוח טוב

        public virtual void SayHello() { }
       
        public abstract void SayHello(int times);
        public Boolean IsMammals()
        {
            return mammals;
        }
        public void SetMammals(bool b) {
            mammals = b;
        }
        public Boolean Iscomivorous()
        {
            return comivorous;
        }
        public void Setcomivorous(bool b) {
            comivorous = b;
        }

        public override string ToString()
        {
            return $"Animal Name:{GetType().Name}: mammals: {mammals}, comivorous: {comivorous},mood: {mood} ";
        }


    }
}
