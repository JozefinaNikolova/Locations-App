var React = require('react');
var AllLocationsRow = require('./AllLocationsRow.jsx');
var LocationActions = require('../../actions/LocationActions');

var AllLocationsList = function (props) {

    handleAddFave = function(location){
        LocationActions.favoriteLocation(location);
    };

    handleDeleteLocation = function(location){
        LocationActions.deleteLocation(location);
    };

    handleEditLocation = function(location){
        LocationActions.editLocation(location);
    };

    return (
        <ul>
            {props.locations.map((location) => {
                return (
                    <AllLocationsRow
                        location={location}
                        addFave={this.handleAddFave}
                        deleteLocation={this.handleDeleteLocation}
                        editLocation={this.handleEditLocation}
                    />
                );
            })}
        </ul>
    );
};

AllLocationsList.propTypes = {
    locations: React.PropTypes.array
};

AllLocationsList.propTypes = {
    locations: React.PropTypes.array
};

module.exports = AllLocationsList;

