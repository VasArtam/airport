using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace airplane
{
	public class Passenger
	{
		public Passport Passport { get; set; }
		public uint BaggageWeight { get; set; }
		public TypeOfFood TypeOfFood { get; set; }
		public Ticket Ticket { get; set; }
		public List<Route> Flights { get; set; }
		public Guid BusId { get; set; }

		[JsonConstructor]
		public Passenger(Passport passport, uint baggageWeight, TypeOfFood typeOfFood, Ticket ticket, List<Route> flights, Guid busId)
		{
			Passport = passport;
			BaggageWeight = baggageWeight;
			TypeOfFood = typeOfFood;
			Ticket = ticket;
			Flights = flights;
			BusId = busId;
		}
	}
	public enum TypeOfFood : int
	{
		Normal,
		Vegan
	}
	public class Passport
	{
		public Guid Guid { get; set; }
		public string Surname { get; set; }
		public string GivenNames { get; set; }
		public string Nationality { get; set; }
		public DateTime DateOfBirth { get; set; }
		public Sex Sex { get; set; }

		[JsonConstructor]
		public Passport(Guid guid, string surname, string givenNames, string nationality, DateTime dateOfBirth, Sex sex)
		{
			Guid = guid;
			Surname = surname;
			GivenNames = givenNames;
			Nationality = nationality;
			DateOfBirth = dateOfBirth;
			Sex = sex;
		}
	}
	public enum Sex
	{
		Male,
		Female
	}
	public class Ticket
	{
		public Guid tID;
		public Guid pID; //passenger ID
		public int fID; //flight ID
		public string city;
		public string pName;
		public string pSecondName;
		public Sex sex;

		[JsonConstructor]
		public Ticket(Guid tId, Guid pId, int fId, string city, string pName, string pSecondName, Sex sex)
		{
			tID = tId;
			pID = pId;
			fID = fId;
			this.city = city;
			this.pName = pName;
			this.pSecondName = pSecondName;
			this.sex = sex;
		}
	}

	public class Baggage
	{

	}

	public class Food
	{

	}

	public class Route
	{
		public string frm { get; set; }
		public string to { get; set; }
		public int timeStart { get; set; }
		public int timeStop { get; set; }
		public int? count { get; set; }
		public int reisNumber { get; set; }
		public int? plain { get; set; }
		public int? registrtionTime { get; set; }
		public int? boardingTime { get; set; }

		public Route() { }

		[JsonConstructor]
		public Route(string frm, string to, int timeStart, int timeStop, int? count, int reisNumber, int? plain, int? registrtionTime, int? boardingTime)
		{
			this.frm = frm;
			this.to = to;
			this.timeStart = timeStart;
			this.timeStop = timeStop;
			this.count = count;
			this.reisNumber = reisNumber;
			this.plain = plain;
			this.registrtionTime = registrtionTime;
			this.boardingTime = boardingTime;
		}
	}
}
