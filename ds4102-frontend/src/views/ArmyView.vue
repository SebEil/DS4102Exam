<template>
    <section>
        <h2>Overview of all things in the troop</h2>
        <missions-list></missions-list>
        <soldier-list></soldier-list>
        <vehicle-list></vehicle-list>
    </section>
</template>

<script>

import SoldierList from "../components/soldiers/SoldierItem.vue"
import MissionsList from "../components/missions/MissionsList.vue"
import VehicleList from "../components/Vehicles/VehicleList.vue"

export default {
    components: {
        MissionsList,
        SoldierList,
        VehicleList
    }
}
</script>