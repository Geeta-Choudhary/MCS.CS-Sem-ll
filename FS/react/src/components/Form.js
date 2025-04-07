import React,{Component} from 'react';
import  '../Form.css';

class Form extends Component {
    constructor(props){
        super(props);
        this.state ={
            name:'',
            email:'',
        };
    }

    handleChange= (event) => {
        this.setState({
            [event.target.name]:event.target.value
        });
    };

    handleSubmit =(event) =>{
        event.preventDefault();
        this.props.onFormSubmit(this.state)
        this.setState({name:'', email:''});
        //alert(`Submitted Name: ${this.state.name}\n Submitted Email : ${this.state.email}`);
    };

    render(){
        return(
            <div className="form-container">
                <h2>Enter Details Here</h2>
                <form onSubmit={this.handleSubmit}>
                    <label>Name :</label>
                    <input
                    type="text"
                    name="name"
                    value={this.state.name}
                    onChange={this.handleChange}
                    required />

                    <label>Email :</label>
                    <input
                    type="email"
                    name="email"
                    value={this.state.email}
                    onChange={this.handleChange}
                    required />

                    <button type="submit"> Submit</button>
                </form>
            </div>
        );
    }
}

export default Form;