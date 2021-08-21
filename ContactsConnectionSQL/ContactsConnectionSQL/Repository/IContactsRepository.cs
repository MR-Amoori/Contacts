using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ContactsConnectionSQL
{
	interface IContactsRepository
	{
		DataTable selectall();
		DataTable selectrow(int _ID);
		DataTable search(string parameter);
		bool insetr(string name, string family, string numberphone, string email, int age, string addresss);
		bool update(int _ID, string name, string family, string numberphone, string email, int age, string addresss);
		bool delete(int _ID);
        bool ChagePassword(string username, int password);
	}
}
