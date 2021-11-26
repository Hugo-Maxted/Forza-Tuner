import "./main.css";
import React from "react";
import ReactDOM from "react-dom";

interface carType {
  class: "d" | "c" | "b" | "a" | "s1" | "s2" | "x";
  category: "road" | "dirt" | "offroad" | "drag" | "drift";
  drivetrain: "fwd" | "rwd" | "awd";
}

const calcValue: (car: carType, setting: string) => string = (car: carType, setting: string): string => {
  switch (setting) {
    case "dif.front.acc":
      switch (car.category) {
        case "road":
          return "25";
        case "dirt":
          return "25";
        case "offroad":
          return "100";
        case "drag":
          return "100";
        case "drift":
          return "100";
      }
    case "dif.front.dec":
    case "dif.rear.dec":
      switch (car.category) {
        case "road":
          return "10";
        case "dirt":
          return "10";
        case "offroad":
          return "100";
        case "drag":
          return "100";
        case "drift":
          return "100";
      }
    case "dif.center":
      switch (car.category) {
        case "road":
          return "70";
        case "dirt":
          return "70";
        case "offroad":
          return "50";
        case "drag":
          return "70";
        case "drift":
          return "100";
      }
    case "dif.rear.acc":
      switch (car.category) {
        case "road":
          return "50";
        case "dirt":
          return "50";
        case "offroad":
          return "100";
        case "drag":
          return "100";
        case "drift":
          return "100";
      }
    default:
      return "";
  }
}

const Setting: (props: { car: carType, setting: string }) => JSX.Element = (props: { car: carType, setting: string }): JSX.Element => {
  switch (props.setting) {
    case "differential":
      switch (props.car.drivetrain) {
        case "fwd":
          return <>
            <h4>Front:</h4>
            <h5>Acceleration: {calcValue(props.car, "dif.front.acc")}</h5>
            <h5>Deceleration: {calcValue(props.car, "dif.front.dec")}</h5>
          </>
        case "rwd":
          return <>
            <h4>Front:</h4>
            <h5>Acceleration: {calcValue(props.car, "dif.front.acc")}</h5>
            <h5>Deceleration: {calcValue(props.car, "dif.front.dec")}</h5>
            <h4>Center: {calcValue(props.car, "dif.center")}</h4>
            <h4>Rear:</h4>
            <h5>Acceleration: {calcValue(props.car, "dif.rear.acc")}</h5>
            <h5>Deceleration: {calcValue(props.car, "dif.rear.dec")}</h5></>
        case "awd":
          return <>
            <h4>Rear:</h4>
            <h5>Acceleration: {calcValue(props.car, "dif.rear.acc")}</h5>
            <h5>Deceleration: {calcValue(props.car, "dif.rear.dec")}</h5></>
      }
    default:  
    return <div></div>
  }
}

const App: () => JSX.Element = (): JSX.Element => {
  const [type, setType] = React.useState<carType>({
    class: "a",
    category: "road",
    drivetrain: "rwd",
  });

  return (
    <div className="content">
      <h1>Car Setup:</h1>
      <h3>Racing Discipline:</h3>
      <div>
        <div className={"button " + (type.category === "road" ? "active" : "")} onClick={(): void => setType((type): carType => ({...type, category: "road"}))}>
          Road
        </div>
        <div className={"button " + (type.category === "dirt" ? "active" : "")} onClick={(): void => setType((type): carType => ({...type, category: "dirt"}))}>
          Dirt
        </div>
        <div className={"button " + (type.category === "offroad" ? "active" : "")} onClick={(): void => setType((type): carType => ({...type, category: "offroad"}))}>
          Offroad
        </div>
        <div className={"button " + (type.category === "drag" ? "active" : "")} onClick={(): void => setType((type): carType => ({...type, category: "drag"}))}>
          Drag
        </div>
        <div className={"button " + (type.category === "drift" ? "active" : "")} onClick={(): void => setType((type): carType => ({...type, category: "drift"}))}>
          Drift
        </div>
      </div>
      <h3>DriveTrain:</h3>
      <div>
        <div className={"button " + (type.drivetrain === "fwd" ? "active" : "")} onClick={(): void => setType((type): carType => ({...type, drivetrain: "fwd"}))}>
          FWD
        </div>
        <div className={"button " + (type.drivetrain === "rwd" ? "active" : "")} onClick={(): void => setType((type): carType => ({...type, drivetrain: "rwd"}))}>
          RWD
        </div>
        <div className={"button " + (type.drivetrain === "awd" ? "active" : "")} onClick={(): void => setType((type): carType => ({...type, drivetrain: "awd"}))}>
          AWD
        </div>
      </div>
      <h3>Class:</h3>
      <div>
        <div className={"button " + (type.class === "d" ? "active" : "")} onClick={(): void => setType((type): carType => ({...type, class: "d"}))}>
          D
        </div>
        <div className={"button " + (type.class === "c" ? "active" : "")} onClick={(): void => setType((type): carType => ({...type, class: "c"}))}>
          C
        </div>
        <div className={"button " + (type.class === "b" ? "active" : "")} onClick={(): void => setType((type): carType => ({...type, class: "b"}))}>
          B
        </div>
        <div className={"button " + (type.class === "a" ? "active" : "")} onClick={(): void => setType((type): carType => ({...type, class: "a"}))}>
          A
        </div>
        <div className={"button " + (type.class === "s1" ? "active" : "")} onClick={(): void => setType((type): carType => ({...type, class: "s1"}))}>
          S1
        </div>
        <div className={"button " + (type.class === "s2" ? "active" : "")} onClick={(): void => setType((type): carType => ({...type, class: "s2"}))}>
          S2
        </div>
        <div className={"button " + (type.class === "x" ? "active" : "")} onClick={(): void => setType((type): carType => ({...type, class: "x"}))}>
          X
        </div>
      </div>
      <br />
      <h1>Car Tuning:</h1>
      <h3>Differential:</h3>
      <Setting car={type} setting="differential" />
    </div>
  );
};

ReactDOM.render(
  <React.StrictMode>
    <App />
  </React.StrictMode>,
  document.getElementById("root"),
);
