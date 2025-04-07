import React,{ Component } from  'react';
import '../DataFetcher.css';

class DataFetcher extends Component {
    render (){
        return(
            <div className='data-container'>
                <h2>Fetched Form Data</h2>
                {this.props.formData.length > 0 ?(
                    <ul>
                        {this.props.formData.map((data,index)=> (
                            <li key={index}>
                                <strong>Name:</strong> {data.name } <br/>
                                <strong>Email:</strong> {data.email }
                            </li>
                        ))}
                    </ul>
                ) :(
                    <p> No data Submitted yet .</p>
                )}
            </div>
        );
    }
}

export default DataFetcher;