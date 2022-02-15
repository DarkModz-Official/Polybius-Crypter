using System;
using System.Globalization;

namespace Matriz
{
	public abstract class Alphabet
	{
		protected char[] alphabet = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'Ä', 'Ö', 'Ü', ' ' };  //Alphabet

	}

	public class Matrix : Alphabet
	{

		private const int feldX = 5; // Legt X für Matrix size an
		private const int feldY = 6; // Legt Y für Matrix size an
		private char[,] FeldMatrix = new char[feldX, feldY]; // Initzialisierung für Matrix

		public Matrix(string keyword) // Constructor für das Objekt
		{
			char[] splitted = keyword.ToCharArray();

			/*
			 * KeyWord in Matrix speichern
			 */

			int iSplitStateX = 0, iSplitStateY = 0; // CursorPosition speichern

			foreach (char c in splitted)
			{
				if (!InMatrix(c))
				{


					if (iSplitStateX > feldX - 1)   // Bei Spaltenende X; Spalte Y hochzählen
					{

						FeldMatrix[iSplitStateY, iSplitStateX] = c; // Aktueller Char in Matrix speichern

						iSplitStateX = 0;   // Reset X bei Ende
						iSplitStateY++; // Array Cursor in nächste Zeile schieben
					}
					else
					{

						FeldMatrix[iSplitStateY, iSplitStateX] = c; // Aktueller Char in Matrix speichern
						iSplitStateX++; // X hochzählen für bearbeitung der nächsten Spalte
					}
				}
			}

			/*
			 * Alphabet in Matrix speichern
			 */

			foreach (char c in alphabet)
			{
				if (!InMatrix(c))
				{

					if (iSplitStateX > feldX - 1)   // Bei Spaltenende X; Spalte Y hochzählen
					{
						FeldMatrix[iSplitStateY, iSplitStateX] = c; // Aktueller Char in Matrix speichern

						iSplitStateX = 0;   // Reset X bei Ende
						iSplitStateY++; // Array Cursor in nächste Zeile schieben
					}
					else
					{
						FeldMatrix[iSplitStateY, iSplitStateX] = c; // Aktuellen Char in Matrix speichern
						iSplitStateX++; // X hochzählen für bearbeitung der nächsten Spalte
					}
				}
			}

		}

		public bool InMatrix(char CharTest)
		{
			// Prüfung ob Char bereits vorhanden
			foreach (char MatrixChar in FeldMatrix)
			{
				if (MatrixChar == CharTest) // Abgleich mit aktuellem Char der Matrix
				{
					return true;    //Ausgabe True da Buchstabe bereits in Matrix
				}
			}
			return false;   //Ausgabe False da Buchstabe nicht in Matrix
		}

		public string GetIndex(char CharGet)
		{

			for (int i1 = 0; i1 < feldX; i1++) // Array X Index Abfragen
			{
				for(int i2 = 0; i2 < feldY; i2++) // Array y Index Abfragen
				{
					if(CharGet == FeldMatrix[i1, i2])
					{
						return i1 + "" + i2;	//ARRAY Index ausgeben
					}
				}
			}

			return "Error";	// Error!
		}

		public char GetChar(int iX, int iY)
		{
			return FeldMatrix[iX, iY];	//Char Index auslesen
		}

		public string Encrypt(string input)
		{
			char[] splitted = input.ToCharArray();	//In Array Umwandeln
			string feedback = "";

			foreach (char c in splitted)
			{
				feedback += GetIndex(c) + " ";	// Index Heraussuchen!
			}

			return feedback;	// Index ausgeben
		}

		public string Decrypt(string input)
		{
			string[] splitted = input.Split(' ');

			string feedback = "";
			for (int i = 0; i < splitted.Length; i++)
			{
				char[] zahl = splitted[i].ToString().ToCharArray(); // INDEX in ARRAY umwandeln
				int iX = CharUnicodeInfo.GetDecimalDigitValue(zahl[0]);	// ASCII zu Char Umwandeln
				int iY = CharUnicodeInfo.GetDecimalDigitValue(zahl[1]); // ASCII zu Char Umwandeln
				feedback += GetChar(iX, iY);	//Zeichen Speichern
			}
			return feedback;	//Zeichen Wiedergeben
		}

	}
}