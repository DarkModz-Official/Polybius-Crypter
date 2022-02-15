using System;

namespace Matriz
{
	public abstract class Alphabet
	{
		private virtual const char[] alphabet = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'Ä', 'Ö', 'Ü', 'ß', ' ' };  //Alphabet

	}

	internal class Matrix : Alphabet
	{

		private char[5][6] Matrix = { '' }; // Constructor für Matrix

		public Matrix(string keyword)
		{
			char[] splitted = keyword.Split('');

			/*
			 * KeyWord in Matrix speichern
			 */

			int iSplitStateX = 0, iSplitStateY = 0; // CursorPosition speichern

			foreach (char c in splitted)
			{
				if (!InMatrix(c))
				{


					if (iSplitStateX > 5)   // Bei Spaltenende X; Spalte Y hochzählen
					{

						Matrix[iSplitStateX][iSplitStateY] = c; // Aktueller Char in Matrix speichern

						iSplitStateX = 0;   // Reset X bei Ende
						iSplitStateY++; // Array Cursor in nächste Zeile schieben
					}
					else
					{

						Matrix[iSplitStateX][iSplitStateY] = c; // Aktueller Char in Matrix speichern
						iSplitStateX++; // X hochzählen für bearbeitung der nächsten Spalte
					}
				}
			}

			/*
			 * Alphabet in Matrix speichern
			 */

			foreach (char c in alphabet)
			{
				if (!IsMatrix(c))
				{

					if (iSplitStateX > 5)   // Bei Spaltenende X; Spalte Y hochzählen
					{
						Matrix[iSplitStateX][iSplitStateY] = c; // Aktueller Char in Matrix speichern

						iSplitStateX = 0;   // Reset X bei Ende
						iSplitStateY++; // Array Cursor in nächste Zeile schieben
					}
					else
					{
						Matrix[iSplitStateX][iSplitStateY] = c; // Aktuellen Char in Matrix speichern
						iSplitStateX++; // X hochzählen für bearbeitung der nächsten Spalte
					}
				}
			}

		}

		public bool InMatrix(char CharTest)
		{
			// Prüfung ob Char bereits vorhanden
			foreach (char MatrixChar in Matrix)
			{
				if (MatrixChar == CharTest) // Abgleich mit aktuellem Char der Matrix
				{
					return true;    //Ausgabe True da Buchstabe bereits in Matrix
				}
			}
			return false;   //Ausgabe False da Buchstabe nicht in Matrix
		}

	}
}