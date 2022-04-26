<template>
    <section>
        <article class="row align d-flex justify-content-center">
        <mission-item
            class="container col p-2 text-center" v-for="(mission, i) in missions"
            :key="i"
            :MissionId="mission.MissionId"
            :MissionName="mission.MissionName"
            :MissionLocation="mission.MissionLocation"
            :SoldiersDeployed="mission.SoldiersDeployed">
            </mission-item>
        </article>
    </section>
</template>

<script>
import MissionItem from "../missions/MissionItem.vue"
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

<style>
    .container{
        padding: 1rem;
        background-color: rgb(161, 148, 148);
        border-radius: 25px;
        margin-bottom: 1rem;
        display: inline-block;
    }


</style>