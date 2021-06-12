<p align="center">
  <img width="120" height="120" src="RpgNotes.Web/wwwroot/images/quests.logo.svg">
</p>

# RPG Notes
RPG Notes is a Blazor WebAssembly progressive web app (PWA) for assisting players of tabletop roleplaying games in organizing notes taken during their gameplay sessions. 

# License
The code in this project is licensed under the following [LICENSE](LICENSE).

# Usage
## Compatibility
This application should be functional on all "modern" web browsers. 

## Persistance
It uses your browser's local cache as a storage device to save application data to. While this means that in most cases you can close the app and re-open it without losing any data, there are cases where your web-browser's cache may be cleared in which case this app will lose its data too. In order to save a permanent copy of the app data you can use the &#8942; menu on the main page of the app (where you select an active campaign) and select Export JSON to trigger a file download of the app data. This file can be re-imported using the same menu, but selecting Import JSON instead. 

## Basic Functionality
1. Create a campaign using the '+' button in the header bar of the `Campaigns` page.
   1. Define a name and what RPG system you are using. Use **Other** if your system is not listed.
2. Select the campaign to make notes for
3. Within any category **Characters**, **Quests**, etc. use the '+' button to create a new entry
   1. Name the entry and provide a brief description (optional). 
4. Select any entry within a category to view its details
   1. Change description
   2. Add notes
   3. Add organizational tags
   4. Add images
      1. From public online sources
      2. Uploaded from a local file
   5. Create connections to other entries using the **Connections** tab
      1. Relationships between characters
      2. Possession of items
      3. Relative position of locations
