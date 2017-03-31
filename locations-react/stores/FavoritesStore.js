var alt = require('../alt');
var LocationActions = require('../actions/LocationActions');

class FavoritesStore {
    constructor() {
        this.locations = [];

        this.bindListeners({
            getFavorites: LocationActions.GET_FAVORITES,
            addFavoriteLocation: LocationActions.FAVORITE_LOCATION
        });
    }

    getFavorites(data){
        this.locations = data.locations;
    }

    addFavoriteLocation(location) {
        this.locations.push(location);
    }
}

module.exports = alt.createStore(FavoritesStore, 'FavoritesStore');