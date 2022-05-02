<template>
    <section>
        <h2 class="text-center">Army Admin Page</h2>
        <edit-mission></edit-mission>
        <missions-list></missions-list>
        <soldier-list></soldier-list>
        <edit-vehicles></edit-vehicles>
        <vehicle-list></vehicle-list>
        <edit-weapons></edit-weapons>
        <weapon-list></weapon-list>
    </section>
</template>


<script>
import EditMission from '../components/missions/EditMission.vue'
import MissionsList from '../components/missions/MissionsList.vue'
import SoldierList from '../components/soldiers/SoldierList.vue'
import EditVehicles from '../components/Vehicles/EditVehicles.vue'
import VehicleList from '../components/Vehicles/VehicleList.vue'
import EditWeapons from '../components/Weapons/EditWeapons.vue'
import WeaponList from '../components/Weapons/WeaponList.vue'



export default {
    components: { 
        MissionsList,
        EditMission,
        SoldierList,
        VehicleList,
        EditVehicles,
        EditWeapons,
        WeaponList 
    }
}
</script>

<style scoped>
    .text-center{
        margin-top: -1.9rem ;
    }
</style>

