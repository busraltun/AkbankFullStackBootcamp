using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo_App
{
   public class Board
    {
        //Board TODO - IN PROGRESS - DONE kolonlarından oluşmalı.
        //TODO INPROGRESS DONE kolonlari olmali
        //İlgili kolonlar Card tipli List yapısı olarak tutulmuştur
        public static List<Kart> ToDo;
        public static List<Kart> InProgress;
        public static List<Kart> Done;

        public Board()
        {
            ToDo = DefaultToDoCards();
            InProgress = DefaultInProgressCard();
            Done = DefaultDoneCards();
        }
        public static List<Kart> DefaultToDoCards()
        {
            return new List<Kart>(){
                new Kart("Title - 1","Content -1",1,Buyukluk.S)
            };
        }
        public static List<Kart> DefaultInProgressCard()
        {
            return new List<Kart>(){
                new Kart("Title - 2","Content -2",2,Buyukluk.M)
            };
        }
        public static List<Kart> DefaultDoneCards()
        {
            return new List<Kart>(){
                new Kart("Title - 3","Content -3",3,Buyukluk.XL)
            };
        }
    }
}
