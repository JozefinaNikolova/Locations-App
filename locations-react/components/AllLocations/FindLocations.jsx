var React = require('react');
var LocationActions = require('../../actions/LocationActions');

var FindLocations = function () {
    handleUserInput = function(e) {
        debugger;
        var locationName = e.target.value;
        LocationActions.findLocations(locationName);
    };

    return (
        <div>
            <div>Search:</div>
            <input type="text" onChange={this.handleUserInput}/>
        </div>
    );
};

module.exports = FindLocations;