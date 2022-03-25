import { YMaps, Map as YMap, Placemark } from 'react-yandex-maps'

const mapData = {
  // Координаты центра карты.
  // Порядок по умолчанию: «широта, долгота».
  // Чтобы не определять координаты центра карты вручную,
  // воспользуйтесь инструментом Определение координат.
  center: [43.414707, 39.949854],
  // Уровень масштабирования. Допустимые значения:
  // от 0 (весь мир) до 19.
  zoom: 15,
}

const coordinates = [[43.414707, 39.949854]]

const Map = (props) => {
  var dots = props.data.branches.map((b) => {
    console.log(b.address)
  })

  return (
    <div className="map-container">
      <YMaps>
        <YMap defaultState={mapData} width="auto" height="700px">
          {props.data.branches.map((b) => {
            const geo = [];
            geo.push(b.address.geolocation.geographicCoordinates.latitude);
            geo.push(b.address.geolocation.geographicCoordinates.longitude)
            return (
              <Placemark
                geometry={geo}
              />
            )
          })}
          {props.data.devices.map((d) => (
            <Placemark
              geometry={[
                d.address.geolocation.geographicCoordinates.latitude,
                d.address.geolocation.geographicCoordinates.longitude,
              ]}
            />
          ))}
        </YMap>
      </YMaps>
    </div>
  )
}

export default Map
