var alt = require('../alt');
var LocationActions = require('../actions/LocationActions');

class LocationStore {
    constructor() {
        this.locations = [];
        this.errorMessage = null;
        this.isLoading= true;

        this.bindListeners({
            getLocations: LocationActions.GET_LOCATIONS,
            handleAddLocation: LocationActions.ADD_LOCATION,
            handleDeleteLocation: LocationActions.DELETE_LOCATION,
            handleEditLocation: LocationActions.EDIT_LOCATION,
            handleFindLocations: LocationActions.FIND_LOCATIONS
        });
    }

    getLocations(data){
        this.locations = data.locations;
        this.errorMessage = data.errorMessage;
        this.isLoading = false;
    }

    handleAddLocation(location){
        this.locations.push(location);
    }

    handleDeleteLocation(location){
        var index = this.locations.findIndex(x => x.Id == location.Id);
        this.locations.splice(index, 1);
    }

    handleEditLocation(location){
        var index = this.locations.findIndex(x => x.Id == location.Id);
        this.locations[index].Name = location.Name;
    }

    handleFindLocations(locations){
        this.locations = locations;
    }
}

module.exports = alt.createStore(LocationStore, 'LocationStore');
