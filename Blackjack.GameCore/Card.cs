using System;

namespace Blackjack.GameCore
{
    public class Card
    {
        int value;
        public int Value
        {
            get { return value; }   // здесь указываются условие: что возвращает свойство, когда к нему обращаются. В данном случае вернется 
                                     // значение поля height. Взять значение этого поля извне напрямую мы не можем, тк оно private
            set { this.value = value; }  // здесь условие для присвоения значения. В данном случае когда пользователь присваивает значение свойству
                                     // Height, это значение записывается в поле height.
        }

        //public SuitType Suit
        //{ }

        //public string Rank
        //{
        //    get
        //    {
        //        return [ЗДЕСЬ БУДЕТ ВАШ КОД];
        //    }
        //}
    }
}
