var React = require('react');
var LocationActions = require('../../actions/LocationActions');

var AllLocationsRow = React.createClass({
    getInitialState(){
        return {
            isEditClicked: false,
            isFaved: this.props.location.HasFavorite,
            editedLocationName: this.props.location.Name
        }
    },

    handleChange(e) {
        this.setState({
            editedLocationName: e.target.value
        });
    },

    editOnClick(){
        if(this.state.isEditClicked){
            this.handleEditLocation();
        }

        this.setState({
           isEditClicked: (!this.state.isEditClicked)
        });
    },

    handleAddFave(){
        this.setState({
            isFaved: true
        });
        return this.props.addFave(this.props.location);
    },

    handleDeleteLocation(){
        return this.props.deleteLocation(this.props.location);
    },

    handleEditLocation(){
        var newLocation = {
            id: this.props.location.Id,
            name: this.state.editedLocationName
        };
        return this.props.editLocation(newLocation);
    },

    render() {
        var faveButton = (
            <button onClick={this.handleAddFave}>
                Favorite
            </button>
        );

        var deleteButton = (
            <button onClick={this.handleDeleteLocation}>
                Delete
            </button>
        );

        var editButton =(
            <button onClick={this.editOnClick}>
                Edit
            </button>
        );

        var input = (
            <div>
                <input type="text" onChange={this.handleChange}/>
            </div>
        );

        return (
            <li id={this.props.location.Id}>
                <div>{this.props.location.Name}</div>
                {this.state.isEditClicked ? input : ''}
                {this.state.isFaved ? '<3' : faveButton}
                {deleteButton}
                {editButton}
            </li>
        )
    }
});

module.exports = AllLocationsRow;
