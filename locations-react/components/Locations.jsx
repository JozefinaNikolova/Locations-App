var React = require('react');
var AltContainer = require('alt/AltContainer');
var LocationStore = require('../stores/LocationStore');
var FavoritesStore = require('../stores/FavoritesStore');
var Favorites = require('./Favorites.jsx');
var AllLocationsContainer = require('./AllLocations/AllLocationsContainer.jsx');


var Locations = React.createClass({
    render() {
        return (
            <div>
                <h1>Locations</h1>
                <AltContainer store={LocationStore}>
                    <AllLocationsContainer />
                </AltContainer>

                <h1>Favorites</h1>
                <AltContainer store={FavoritesStore}>
                    <Favorites />
                </AltContainer>
            </div>
        );
    }
});

module.exports = Locations;
