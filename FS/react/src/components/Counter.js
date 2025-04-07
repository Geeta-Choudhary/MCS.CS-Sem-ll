import React , {Component } from  'react';
import '../Counter.css';

class Counter extends Component {
    constructor(props){
        super(props);
        this.state ={
            count :0,
        };
    }
    incrementCount = () => {
        this.setState({count: this.state.count + 1});
    };

    render(){
        return(
            <div className="counter-container">
                <h3>
                    Count: {this.state.count}
                </h3>
                <button className="counter-button" onClick={this.incrementCount}>Increment</button>
            </div>
        );
    }
}

export default Counter;