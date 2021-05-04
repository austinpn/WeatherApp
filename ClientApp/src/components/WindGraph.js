import React from 'react'
import { collapseTextChangeRangesAcrossMultipleVersions } from 'typescript';




class WindGraph extends React.Component{
    constructor(props){
        super(props);
        this.state={width: 0, styles: {}}
        this.graphRef = React.createRef();


    }
    componentDidMount(){
        this.fixDpi();
        this.drawGraph();
        this.drawWindLines();
    }
    render(){
        return(
            <canvas className="WindGraph" ref={this.graphRef}>
            </canvas>
        )
    }

    fixDpi = () => {
        let canvas = this.graphRef.current;
        let style_width = +getComputedStyle(canvas).getPropertyValue("width").slice(0,-2);
        let style_height = +getComputedStyle(canvas).getPropertyValue("height").slice(0,-2);
        let dpi=window.devicePixelRatio;
        canvas.setAttribute('height', style_height*dpi);
        canvas.setAttribute('width', style_width*dpi);
    }
    drawGraph = ()=>{
        let widthStep = this.graphRef.current.width/24;
        let heightStep = this.graphRef.current.height/10;
        let c = this.graphRef.current.getContext('2d');


        c.beginPath();
        for(let i=1; i<10; i++){
            c.moveTo(0, i*heightStep);
            c.lineTo(this.graphRef.current.width, i*heightStep);
            
        }
        for(let i=1; i<24; i++){
            c.moveTo(i*widthStep, 0);
            c.lineTo(i*widthStep, this.graphRef.current.width);
            // c.stroke();
        }
        c.stroke();
    }
    drawWindLines = ()=>{
        let pointSpacing = this.graphRef.current.width / (this.props.periods.length);
        let height = this.graphRef.current.height;
        let c = this.graphRef.current.getContext('2d');
        let numToYCoord = (num) => ((-1*(height/50)*num)+height);

        c.beginPath();
        c.lineWidth=5;
        c.moveTo(0, numToYCoord(this.props.periods[0].windSpeedMPH));
        for(let i=1; i<this.props.periods.length; i++){
            c.lineTo(i*pointSpacing, numToYCoord(this.props.periods[i].windSpeedMPH) );
        }
        c.stroke();
    }
    
}

export default WindGraph;