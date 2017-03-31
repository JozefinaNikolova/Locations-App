var React = require('react');
var LocationActions= require('../actions/LocationActions');

var Favorites = React.createClass({
    componentWillMount(){
        LocationActions.getFavorites();
    },

    render() {
        return (
            <ul>
                {this.props.locations.map((location, i) => {
                    return (
                        <li key={i}>{location.Name}</li>
                    );
                })}
            </ul>
        );
    }
});

module.exports = Favorites;