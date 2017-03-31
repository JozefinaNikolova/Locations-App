var React = require('react');
var LocationActions = require('../../actions/LocationActions');

var AddLocation = React.createClass({
    getInitialState: function () {
        return {
            locationName: ''
        };
    },

    handleUserInput: function (e) {
        this.setState({
            locationName: e.target.value
        });
    },

    handleAddLocation: function (e){
        var location = {
            Name: this.state.locationName
        };

        LocationActions.addLocation(location);
    },

    render: function () {
        return (
            <div>
                <div>Add new location:</div>
                <input type="text" onChange={this.handleUserInput}/>
                <button onClick={this.handleAddLocation} >
                    Add
                </button>
            </div>
        );
    }
});

module.exports = AddLocation;