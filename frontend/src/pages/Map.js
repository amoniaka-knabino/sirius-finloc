import { YMaps, Map as YMap, Placemark } from "react-yandex-maps";

const mapData = {
    // Координаты центра карты.
    // Порядок по умолчанию: «широта, долгота».
    // Чтобы не определять координаты центра карты вручную,
    // воспользуйтесь инструментом Определение координат.
    center: [43.414707, 39.949854],
    // Уровень масштабирования. Допустимые значения:
    // от 0 (весь мир) до 19.
    zoom: 15
};

const coordinates = [
    [43.414707, 39.949854]
];


const Map = () => {
    return (
        <YMaps>
            <YMap defaultState={mapData}>
                {coordinates.map(coordinate => <Placemark geometry={coordinate} />)}
            </YMap>
        </YMaps>
    );
};

export default Map;