import React from 'react';
import HourlyWeatherSegment from "./HourlyWeatherSegment";
import WindGraph from "./WindGraph";

class HourlyWeather extends React.Component {
    constructor(props) {
        super(props);
        this.state = {
            periods: null,
            latitude: this.props.latitude,
            longitude: this.props.longitude,
            numDays: this.props.numDays,
            stillFetching: true
        }
        this.populateHourPeriods = this.populateHourPeriods.bind(this);

    }

    componentDidMount() {
        this.populateHourPeriods();
    }

    render() {
        let contents = this.state.stillFetching ? 
            <p>Loading...</p> : 
            <WindGraph periods = {this.state.periods}/>;
            // this.state.periods.map((period) => {
            //     return(<HourlyWeatherSegment period={period}/>);
            // });
            
        return (
            <div className="HourlyWeather">
                {contents}
            </div>
            )
    }

    async populateHourPeriods(){
        this.setState({periods: null, stillFetching: true})
        const response = await fetch(`https://localhost:5001/forecast/${this.props.longitude}&${this.props.latitude}&${this.props.numDays}/hourly/wind`);
        const data = await response.json();
        this.setState({periods: data, stillFetching: false});
    }
}

export default HourlyWeather;