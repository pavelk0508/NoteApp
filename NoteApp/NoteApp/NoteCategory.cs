using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
    	/// <summary>
	/// Перечисление категорий заметки
	/// </summary>
    public enum NoteCategory : int
    {
        Work = 1,
        Home,
        HealthAndSport,
        People,
        Documents,
        Finance,
        Miscellaneous
    }
}
