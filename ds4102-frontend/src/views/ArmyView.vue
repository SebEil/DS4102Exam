<template>
    <section>
        <h2>Overview of all things in the troop</h2>
        <missions-list></missions-list>
        <soldier-list></soldier-list>
        <vehicle-list></vehicle-list>
        <weapon-list></weapon-list>
    </section>
</template>

<script>

import SoldierList from "../components/soldiers/SoldierList.vue"
import MissionsList from "../components/missions/MissionsList.vue"
import VehicleList from "../components/Vehicles/VehicleList.vue"
import WeaponList from "../components/Weapons/WeaponList.vue"

export default {
    components: {
        MissionsList,
        SoldierList,
        VehicleList,
        WeaponList
    }
}
</script>

<style scoped>
    h2{
        margin-top: -30px;
        padding-top: 20px;
    }

</style>