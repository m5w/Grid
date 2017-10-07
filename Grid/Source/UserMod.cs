using ICities;

namespace Grid
{
	public class UserMod : IUserMod
	{
		public string Name {
			get {
				return "Grid";
			}
		}

		public string Description {
			get {
				return "Toggle Grid Visibility";
			}
		}
	}
}

