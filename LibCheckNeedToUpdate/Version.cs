namespace LibCheckNeedToUpdate
{   
	public class Version
	{
		string currentVersion;
		string otherVersion;

		public Version(string currentVersion, string otherVersion)
		{
			this.currentVersion = currentVersion;
			this.otherVersion = otherVersion;
		}

		public void CheckData(string currentVersion, string otherVersion)
        {
			string x1 = string.Empty;
			string y1 = string.Empty;
			string z1 = string.Empty;

			string x2 = string.Empty;
			string y2 = string.Empty;
			string z2 = string.Empty;
			
			try
            {
				char[] vArr1 = currentVersion.ToCharArray();
				char[] vArr2 = otherVersion.ToCharArray();

				int counter1 = 0;
				int counter2 = 0;

				foreach (char c in vArr1)
				{
					if (c != ('.'))
					{
						if (counter1 == 0) { x1.Append(vArr1[c]); }
						if (counter1 == 1) { y1.Append(vArr1[c]); }
						if (counter1 == 2) { z1.Append(vArr1[c]); }
					}
					if (c == ('.'))
					{
						counter1++;
					}
				}

				foreach (char c in vArr2)
				{
					if (c != ('.'))
					{
						if (counter2 == 0) { x2.Append(vArr2[c]); }
						if (counter2 == 1) { y2.Append(vArr2[c]); }
						if (counter2 == 2) { z2.Append(vArr2[c]); }
					}
					if (c == ('.'))
					{
						counter2++;
					}
				}
			}
			catch
			{	
				Console.WriteLine("Input versions in right format x.x.x"); 
			}
			finally
            {
				int xV1 = int.Parse(x1);
				int yV1 = int.Parse(y1);
				int zV1 = int.Parse(z1);

				int xV2 = int.Parse(x2);
				int yV2 = int.Parse(y2);
				int zV2 = int.Parse(z2);

				if ((z1 is not null || y1 is not null || x1 is not null) && (z2 is not null || y2 is not null || x2 is not null))
				{
					IsNeedToUpdate(xV1, yV1, zV1, xV2, yV2, zV2);
				}
			}
        }

		public bool IsNeedToUpdate(int xV1, int yV1, int zV1, int xV2, int yV2, int zV2)
		{	 
			if ((xV1 >= xV2 && yV1 >= yV2 && zV1 >= zV2)
				|| (xV1 == xV2 && yV1 == yV2 && zV1 >= zV2)
				|| (xV1 > xV2))
            {
				Console.WriteLine("Needn't to update");
				return false;
            }
			else
            {
				Console.WriteLine("Need to update");
				return true;
            }
        }
	}    
}