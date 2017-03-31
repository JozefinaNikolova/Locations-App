var alt = require('../alt');
var makeRequest = require('../requester');
var baseUrl = 'http://localhost:54118/api/';

class LocationActions {
    getLocations() {
        makeRequest("GET", baseUrl + "Locations/")
            .then(function(data){
                var result = {
                    locations: data,
                    errorMessage: null
                };

                this.dispatch(result);
            }.bind(this), function(error) {
                var result = {
                    errorMessage: error
                };

                this.dispatch(result);
            }.bind(this));
    }

    getFavorites(){
        makeRequest("GET", baseUrl + "Favorites/")
            .then(function(data){
                var result = {
                    locations: data,
                };

                this.dispatch(result);
            }.bind(this));
    }

    favoriteLocation(location) {
        makeRequest("POST", baseUrl + "Favorites/", location)
            .then(function(data){
                this.dispatch(data);
            }.bind(this));
    }

    addLocation(location){
        makeRequest("POST", baseUrl + "Locations/", location)
            .then(function(data){
                this.dispatch(data);
            }.bind(this));
    }

    deleteLocation(location){
        makeRequest("DELETE", baseUrl + "Locations/" + location.Id)
            .then(function (data) {
                this.dispatch(data);
            }.bind(this));
    }

    editLocation(location){
        makeRequest("PUT", baseUrl + "Locations/" + location.Id, location)
            .then(function (data) {
                this.dispatch(data);
            }.bind(this));
    }

    findLocations(locationName){
        makeRequest("GET", baseUrl + "Locations?$filter=substringof('" + locationName + "', Name)")
            .then(function (data) {
                this.dispatch(data);
            }.bind(this));
    }
}

module.exports = alt.createActions(LocationActions);
