<template>
    <section>
        <h2>Current Missions</h2>
        <mission-item
            v-for="(mission, i) in missions"
            :key="i"
            :missionId="mission.missionId"
            :missionName="mission.missionName"
            :missionLocation="mission.missionLocation"
            :soldiersDeployed="mission.soldiersDeployed"
        ></mission-item>
    </section>
</template>

<script>
import MissionItem from "./MissionItem.vue"
import missionService from "../../services/missionService.js"

export default {
    setup(){
        const missions = missionService.getAll();

        return{
            missions
        }
    },
    components: {
        MissionItem
    }   
}
</script>