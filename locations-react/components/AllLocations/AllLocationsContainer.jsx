var React = require('react');
var AllLocationsList = require('./AllLocationsList.jsx');
var AddLocation = require('./AddLocation.jsx');
var FindLocations = require('./FindLocations.jsx');
var LocationActions= require('../../actions/LocationActions');

var AllLocationsContainer = React.createClass({
    getInitialState() {
            return {
                locations: this.props.locations
            }
    },

    componentWillMount(){
        LocationActions.getLocations();
    },

    componentWillReceiveProps(nextProps){
        this.setState({
            locations: nextProps.locations
        });
    },

    render() {
        if (this.props.errorMessage) {
            return (
                <div>{this.props.errorMessage}</div>
            );
        }

        if (this.props.isLoading) {
            return (
                <div>
                    <img src="ajax-loader.gif"/>
                </div>
            )
         }

         else {
                return (
                    <div>
                        <FindLocations />
                        <AddLocation />
                        <AllLocationsList locations={this.state.locations} />
                    </div>
                );
            }
        }
});

module.exports = AllLocationsContainer;