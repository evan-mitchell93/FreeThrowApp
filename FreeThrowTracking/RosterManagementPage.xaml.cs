using Windows.UI.Notifications;

namespace FreeThrowTracking;

public partial class RosterManagementPage : ContentPage
{
	private String? ChosenTeam;
	public RosterManagementPage()
	{
		InitializeComponent();
		//Populate the picker with team names from db
		TeamNamePicker.ItemsSource = App.DataRepository.GetTeams();
	}

	//update the grid of players
	void DisplayPlayers()
	{
		PlayerListCV.ItemsSource = App.DataRepository.GetPlayersByTeam(ChosenTeam);
	}

	//based on picker input query db for players from given team
	void OnTeamSelectedIndexChanged(object sender, EventArgs e)
	{
		var picker = (Picker)sender;
		int SelectedIndex = picker.SelectedIndex;
		if (SelectedIndex != -1)
		{
			//Find all players associated with the team chosen in picker.
			ChosenTeam = picker.Items[SelectedIndex];
			DisplayPlayers();
		}
	}

	//Remove a player from the db based on button click
	void DeletePlayer(object sender, EventArgs e)
	{
		Button button = (Button)sender;
		App.DataRepository.DeletePlayerById((int)button.BindingContext);
		DisplayPlayers();

	}

	//Show input form and create new player object.
	void AddNewPlayer(object sender, EventArgs e)
	{

	}
}